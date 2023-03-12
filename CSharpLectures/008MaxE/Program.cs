/*

int a1 = 10;
int a2 =15;
int a3 =24;
int b1 =15;
int b2 =74;
int b3 =16;
int c1 =17;
int c2 =651;
int c3 =25;

int max = a1;

if (b1>max) max = b1;
if (c1>max) max = c1;


if (a2>max) max = a2;
if (b2>max) max = b2;
if (c2>max) max = c2;

if (a3>max) max = a3;
if (b3>max) max = b3;
if (c3>max) max = c3;

*/

int MAx(int arg1, int arg2, int arg3)
{

int result = arg1;
if (arg2>result) result=arg2;
if (arg3>result) result=arg3;
return result;
}

int a1 = 10;
int a2 =15;
int a3 =24;
int b1 =15;
int b2 =2341;
int b3 =16;
int c1 =17;
int c2 =651;
int c3 =25;

// int max1 = MAx(a1,b1,c1);
// int max2 = MAx(a2,b2,c2);
// int max3 = MAx(a3,b3,c3);
// int maxE=MAx(max1,max2,max3);

int maxE= MAx( MAx(a1,b1,c1), MAx(a2,b2,c2), MAx(a3,b3,c3) );

Console.WriteLine(maxE);
