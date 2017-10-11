namespace Axway.ApiGateway.Model
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.9.1.0")]
    public class FileParameter
    {
        public FileParameter(System.IO.Stream data)
            : this(data, null)
        {
        }

        public FileParameter(System.IO.Stream data, string fileName)
        {
            Data = data;
            FileName = fileName;
        }

        public System.IO.Stream Data { get; private set; }

        public string FileName { get; private set; }
    }
}