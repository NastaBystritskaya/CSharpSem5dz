// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] getArray() {
    int[] massive = new int[5];
    for (int i = 0; i < massive.Length; i++ ) {
        massive [i] = new Random().Next(100, 1000);
    }
    string m = string.Join(", ", massive);
    System.Console.WriteLine(m);
    return massive;
}

int getEven(int[] massive ) {
    int count = 0;
    for (int i = 0; i < massive.Length; i++ ){
        if (massive[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}

void main() {
    int[] arr = getArray();
    int count = getEven(arr);
    System.Console.WriteLine(count);
}

main();

