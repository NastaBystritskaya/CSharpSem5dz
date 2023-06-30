// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] getArray() {
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++) {
        array[i] = (new Random().NextDouble() * (99.9 - 1.0)) + 1.0;
    } 
     System.Console.WriteLine("[" + String.Join(", ", array) + "]");
    return array;
}

double getDifference(double[] array) {
    double maxArray = 0;
    double minArray = 0;
    for(int i =0; i < array.Length; i++) {
        if (array[i] > maxArray) {
            maxArray = array[i];
        }
        if (array[i] < minArray) {
            minArray = array[i];
        }
    }
    double difference = maxArray - minArray;
    return difference;
}

void main() {
    double[] array = getArray();
    double difference = getDifference(array);
    System.Console.WriteLine(difference);
}

main();

