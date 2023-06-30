// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] getArray(){
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1, 101);
    }
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
    return array;
}

int getSum(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 > 0) {
            sum = i + sum;
        }
    } 
    return sum; 
}

void main() {
    int[] Array = getArray();
    int Sum = getSum(Array);
    System.Console.WriteLine(Sum);   
}

main();

