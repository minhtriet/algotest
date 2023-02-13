using System.IO;

namespace AlgoTest { 

    class Program { 
        static void Main(string[] args) {
            string filename = "";
            if (args.Length != 1) {
                Console.WriteLine("No input filename found, default to [algorithms part dataset.csv]");
                filename = "algorithms part dataset.csv";
            } else { 
                filename = args[0];
            }
            if (!File.Exists(filename)) {
                Console.WriteLine($"File {filename} not found");
                return;
            }
            int hasDup = 0;
            BinaryTree binaryTree = new BinaryTree();
            using (StreamReader reader = new StreamReader(filename)) {
                string headerLine = reader.ReadLine();
                while (!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    if (line != null)
                        if (!binaryTree.Add(line))
                        {
                            if (hasDup == 0) 
                                Console.WriteLine("DUPLICATE LINE(S):");
                            hasDup += 1;
                            Console.WriteLine(line);
                        }
                }
            }
            Console.WriteLine($"There are {hasDup} duplicates.");
            //binaryTree.TraversePreOrder(binaryTree.Root);
            //Console.WriteLine();
        }
    }
}

