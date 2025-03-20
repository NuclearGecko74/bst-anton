using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree.Source.DataStructures;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            int option;
            do
            {
                Console.WriteLine("\n--- Menú Árbol Binario ---");
                Console.WriteLine("1. Insertar un valor");
                Console.WriteLine("2. Buscar un valor");
                Console.WriteLine("3. Recorrido PreOrden");
                Console.WriteLine("4. Recorrido InOrden");
                Console.WriteLine("5. Recorrido PostOrden");
                Console.WriteLine("6. Eliminar un nodo");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.Write("Ingrese un valor a insertar: ");
                        if (int.TryParse(Console.ReadLine(), out int insertValue))
                        {
                            if (bst.Insert(insertValue))
                                Console.WriteLine("Valor insertado correctamente.");
                            else
                                Console.WriteLine("El valor ya existe en el árbol.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número válido.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int searchValue))
                        {
                            Console.WriteLine(bst.Contains(searchValue) ? "El valor está en el árbol." : "El valor no está en el árbol.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número válido.");
                        }
                        break;

                    case 3:
                        Console.Write("Recorrido PreOrden: ");
                        bst.PreOrder();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Recorrido InOrden: ");
                        bst.InOrder();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Recorrido PostOrden: ");
                        bst.PostOrder();
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Ingrese el valor a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteValue))
                        {
                            bst.deleteNode(deleteValue);
                            Console.WriteLine("Nodo eliminado si existía en el árbol.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número válido.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (option != 7);
        }
    }
}
