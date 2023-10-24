namespace Model.Repositorio;
public class Repositorio{

    private string nomeRepositorio;
    private string descRepositorio;
    private string linkRepositorio;

    public Repositorio(string nomeRepositorio, string descRepositorio, string linkRepositorio){
        this.nomeRepositorio = nomeRepositorio;
        this.descRepositorio = descRepositorio;
        this.linkRepositorio = linkRepositorio;
    }
        

    public string NomeRepositorio{
        get{return nomeRepositorio;}
        set{nomeRepositorio = value;}
    }

    public string DescRepositorio{
        get{return descRepositorio;}
        set{descRepositorio = value;}
    }

    public string LinkRepositorio{
        get{return linkRepositorio;}
        set{linkRepositorio = value;}
    }


}