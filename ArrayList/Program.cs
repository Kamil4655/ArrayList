using ArrayList.Models;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList arrayList = new IntArrayList();
            arrayList.Add(3);
            arrayList.Add(34);
            arrayList.Add(1);
            arrayList.Add(31);
            arrayList.Add(7);
            arrayList.Add(97);
            arrayList.Add(34);


            //arrayList.Remove(1);
            //arrayList.GetElements();

            
            Console.WriteLine(arrayList.ToString());


            //arrayList.IndexOff(34);
            //arrayList.LastIndexOff(34);

        }
    }
}
