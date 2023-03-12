/*

*/

int MAx(int arg1, int arg2, int arg3)
{

int result = arg1;
if (arg2>result) result=arg2;
if (arg3>result) result=arg3;
return result;
}
//     индексы   0   1   2   3   4   5   6   7   8
int [] array = {163,472,441,553,236,227,874,922,514}; 

 int max = MAx( MAx(array[0],array[1],array[2]), MAx(array[3],array[4],array[5]), MAx(array[6],array[7],array[8]));
 Console.WriteLine(max);