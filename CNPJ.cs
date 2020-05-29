namespace HerançaPOO06
{
    public class CNPJ : Pessoa
    {
        public string cnpj;
        public bool validarCnpj(){
            if(cnpj != ""){
                return true;
            }else{
            return false;
            }
        }
    }
}