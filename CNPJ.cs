namespace Aula06Herança
{
    public class CNPJ
    {
        public string cnpj;
        public bool ValidarCNPJ(){
            if(cnpj != null){
                return true;
            }
            return false;
        }
        
    }
}