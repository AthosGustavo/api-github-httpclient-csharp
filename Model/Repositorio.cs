namespace Model.Repositorio;
public class Repositorio{

    private string name;
    private string description;
    private string html_url;

    public Repositorio(string name, string description, string html_url){
        this.name = name;
        this.description = description;
        this.html_url = html_url;
    }
        

    public string Name{
        get{return name;}
        set{name = value;}
    }

    public string Description
    {
        get{return description;}
        set{description= value;}
    }

    public string Html_url{
        get{return html_url;}
        set{html_url = value;}
    }

    public override string ToString()
    {
        return $"Repositório:\nNome: {name}\nDescrição: {description}\nLink: {html_url}\n";
    }


}