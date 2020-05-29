namespace HerançaPOO06
{
    public class CPF : Pessoa
    {
        public string cpf = "1234567890";
        public string rg;
        public bool validarCpf(){
            if(cpf != ""){
                return true;
                }else{
                return false;
                }
        }
    }
}