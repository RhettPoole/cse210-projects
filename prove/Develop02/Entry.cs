using System;
using System.Collections.Generic;
using System.IO;
class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"[{Date}] {Prompt}: {Response} ";
    }
}