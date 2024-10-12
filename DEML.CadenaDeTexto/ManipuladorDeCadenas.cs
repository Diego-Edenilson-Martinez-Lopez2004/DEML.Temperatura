namespace DEML.CadenaDeTexto
{
    public class ManipuladorDeCadenas
    {
        public string ReverseString(string input)
        {
            char[] arrayCaracteres = input.ToCharArray();
            Array.Reverse(arrayCaracteres);
            return new string(arrayCaracteres);
        }

        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
