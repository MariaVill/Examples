// See https://aka.ms/new-console-template for more information
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection index = new Random().Next(1, 10);
        index++;
    }
}

int [] array = new int[10]; // создай новый массив в котором будет 10 эллементов (нули по умол)

FillArray(array);
PrintArray(array);
