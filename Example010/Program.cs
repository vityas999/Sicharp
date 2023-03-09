int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18}; 

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);// выводит номера индексов где есть число 18(find = 18)
        break;// прекращает поиск индекса и выведет только первое найденое
    }
    //index = index + 1;
    index++;
}
