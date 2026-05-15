int[] arr = [1,3,5,2,6,3,5,8,5];

int buy;
int sell=0;
int buyDay=0;
int sellDay=0;

int profit(int[] arr)
{
    buy=arr[0];
    for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] < buy)
    {
        buy=arr[i];
        buyDay=i;
    }

    if ((arr[i] >= sell) && (buyDay<=sellDay))
    {
        sell=arr[i];
        sellDay=i;
    }
    Console.WriteLine($"Day {i}: Buy Price:{buy}, Sell Price:{sell}, BuyDay:{buyDay}, SellDay:{sellDay}");
}
    if (sell - buy > 0)
    {
        return sell-buy;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine("The max profit that can be registered is "+profit(arr));