// ===========================================================================
//  FILE    : main_script.fsx
//  AUTHOR  : callmekohei <callmekohei at gmail.com>
//  License : MIT license
// ===========================================================================

#load "./loto.fsx"
open Loto.Util

let argv = fsi.CommandLineArgs

let v:Loto =
    if Array.length argv = 1 then
        loto6
    elif argv.[1] = "7" then
        loto7
    else
        loto6

idea04 v 1
|> Seq.fold ( fun acc l -> prettyPrint " " l + "\n" + acc ) ""
|> stdout.Write

idea01 v 1
|> Seq.fold ( fun acc l -> prettyPrint " " l + "\n" + acc ) ""
|> stdout.Write

idea02 v 1
|> Seq.fold ( fun acc l -> prettyPrint " " l + "\n" + acc ) ""
|> stdout.Write

idea03 v 1
|> Seq.fold ( fun acc l -> prettyPrint " " l + "\n" + acc ) ""
|> stdout.Write
