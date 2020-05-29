namespace Aula06Herança
{
    //chamamos a Herança da superclasse 
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(){

            if(cpf != null){
            return true;
            }
        return false;
    }
    }
}