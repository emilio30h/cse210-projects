using System;

class Entry
{
    public string Response { get; set; }
    public string Prompt { get; set; }
    public DateTime Date { get; set; }

    public Entry(string response, string prompt, DateTime date)
    {
        Response = response;
        Prompt = prompt;
        Date = date;
    }
}