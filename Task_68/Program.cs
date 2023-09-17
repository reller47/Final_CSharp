int method(int n, int m)
{
  if (n == 0){
    return m + 1;
}else{
    if ((n != 0) && (m == 0)){
      return method(n - 1, 1);
    }else{
      return method(n - 1, method(n, m - 1));
    }
}
}
Console.Write("Enter M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N = ");
int n = Convert.ToInt32(Console.ReadLine());
if((m > 0) && (n > 0)){
        Console.Write("Result = " + method(m,n));
}else{
    Console.Write(" ERROR !");
}