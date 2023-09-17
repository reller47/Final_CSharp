Console.Write("Enter M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N = ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = m; i <= n; i++){
    sum = sum + i;
}
Console.Write("Result  = " + sum);