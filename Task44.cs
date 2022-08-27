// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
array[1] = 1;
for (int count = 2; count < i; count++) {
    array[count] = array[count - 2] + array[count - 1];
}
Console.WriteLine(string.Join(" ", array));