namespace advc_01
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            #region Generic Class Example
            GenericClassExample<int> genericClassExample = new GenericClassExample<int>(1);
            genericClassExample.Print_maximum(1, 2);
            #endregion

        }
    }
}
