// See https://aka.ms/new-console-template for more information
int[] array = {1, 2, 3, 23, 4, 9, 23, 6, 7, 8, 9};

int n = array.Length;
int find = 23;
int index = 0;

 while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++ ;
}
