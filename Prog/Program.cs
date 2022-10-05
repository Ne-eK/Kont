// Вывод мссива
void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write("[" + array[i] + "] ");
    }
}

// Проверяем массив со строками на условие и перезаписываем данные
string[] CompStr(string[] array){
    int num = 0;
    string temp = string.Empty;
    for(int i = 0; i < array.Length; i++){
        temp = array[i];
        if(temp.Length <= 3) num += 1;
    }
    string[] res = new string[num];
    int k = 0;
    for(int j = 0; j < array.Length; j++){
        temp = array[j];
        if(temp.Length <= 3) {
            res[k] = array[j];
            k++;
        }
    }
   return res;
}

string[] masStr = {"1234", "123", "12345", "12"}; // Задаем массив
Console.WriteLine();
string[] str1 = CompStr(masStr); // вызываем функцию
PrintArray(str1); // Выводим результат
