namespace FileReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "text.zxv";

            try
            {
                Console.WriteLine("Чтение всего файла:");

                using (StreamReader streamReader = new(path))

                {
                    Console.WriteLine(streamReader.ReadToEnd());
                }
                Console.WriteLine();
                Console.WriteLine("Чтение построчно:");

                using (StreamReader streamReader = new(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Чтение блоками:");

                using (StreamReader streamReader = new StreamReader(path, System.Text.Encoding.Default))
                {
                    char[] array = new char[4];
                    // считываем 4 символа
                    streamReader.Read(array, 0, 4);
                    Console.WriteLine(array);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


