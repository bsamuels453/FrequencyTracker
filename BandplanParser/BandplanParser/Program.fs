namespace BandplanParser
module public BandplanParser =
    open System.Net;
    open System.Text.RegularExpressions;
    open System.IO;

    //[<EntryPoint>]
    //let main aregv = 
        //let url = @"https://www.radioreference.com/apps/db/?ctid=201";
    let DownloadCSV (url:string) = 
        let output = "cuckolding.csv";
        let htmlCleanRegex = @"(?s)<table\ class=""rrtable\ content"">.*?</table>";
        let blockRegex2 = @"(?s)<a\ name=""scid\-\d+"">.*?</table>";

        let blockRegex = @"(?s)name=""cid\-\d+"">.*?<a\ name=""cid";

        let categoryRegex = @"(?<=</a>)(.*)(?=</div>)";

        let headerRegex = @"(?<=(^<a\ name=""scid\-\d+""><b>)).*?(?=(</b>))";
        let rowRegex = @"(?s)(?<=(<table\ class=""w1p\ rrtable"">.*?))<tr>.*?</tr>";
        let cellRegex = @"(?<=(<td.*?>)).*?(?=(</td>))";
        let cellCleanRegex = @"(&nbsp;)|(<.*?>)";

        let zoneRegex = @"(?<=<h1 style=""padding-bottom: 5px;"">)(.*)(?=</h1>)"

        let html = (new WebClient()).DownloadString(url)
        let zone = Regex.Matches(html, zoneRegex).Item(0).Value

        let frequencies = 
            (Regex.Matches(Regex.Replace(html, htmlCleanRegex, ""), blockRegex))
            |> Seq.cast<Match> 
            |> List.ofSeq
            |> List.map (fun f -> f.Value)
            |> List.map (fun f -> f.Replace("&amp;", "and"))
            |> List.map (fun f -> f.Replace("&quot;", "'"))
            |> List.map (fun f -> f.Replace("&nbsp;"," "))
            |> List.map (fun f -> f.Replace(@"\t"," "))
            |> List.map (fun f -> 
                Regex.Matches(f, blockRegex2)
                    |> Seq.cast<Match>
                    |> List.ofSeq
                    |> List.map (fun f -> f.Value)
                    |> List.map (fun block ->
                        let category = Regex.Match(f, categoryRegex).Value
                    
                        let header = Regex.Match(block, headerRegex).Value
                        Regex.Matches(block, rowRegex)
                            |> Seq.cast<Match>
                            |> List.ofSeq
                            |> List.map (fun f -> f.Value)
                            |> List.map (fun row -> 
                                Regex.Matches(row, cellRegex)
                                    |> Seq.cast<Match>
                                    |> List.ofSeq
                                    |> List.map (fun cell -> cell.Value)
                                    |> List.map (fun cell -> Regex.Replace(cell, cellCleanRegex, ""))
                            )
                            |> List.filter (fun row -> row.Length = 8)
                            |> List.map (fun f -> f |> List.map (fun item -> item.Replace("\t", "")))
                            |> List.map (fun f -> category::header::f)    
                    )
                )
            |> List.collect (fun f -> List.collect (fun fi -> fi) f)
            |> List.map (fun allocation -> 
                let concat = 
                    allocation 
                        |> List.map (fun s -> s.Replace(',', '-'))
                        |> List.fold (fun state n -> state + "," + n) ""
                concat.Substring(1)
                )
            
        let s = ""
    
        //let entry = "<MemoryEntry><IsFavourite>true</IsFavourite><Name>" + "</Name><GroupName>" + "</GroupName><Frequency>" + "</Frequency><DetectorType>NFM</DetectorType><Shift>0</Shift><FilterBandwidth>10220</FilterBandwidth></MemoryEntry>"
        //let parsed = frequencies |> List.map (fun f -> "<MemoryEntry><IsFavourite>true</IsFavourite><Name>" + f.[0] + " - " + f.[7] + "</Name><GroupName>imported</GroupName><Frequency>" + ((double (f.[2])*1000000.0).ToString()) + "</Frequency><DetectorType>NFM</DetectorType><Shift>0</Shift><FilterBandwidth>10220</FilterBandwidth></MemoryEntry>")
        File.WriteAllLines("freqs.csv", zone::frequencies)
        0 
