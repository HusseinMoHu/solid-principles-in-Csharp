namespace ISP
{
  public class Order : IOrder
  {
    public void AddCashOrder()
    {
      // add cash order
    }

    public void AddCreditOrder()
    {
      // add credit order
    }

    public void AddOnlinePaymentOrder()
    {
      // add online payment order
    }

    public void Complete()
    {
      // complete order
    }

    public void MethodBelongsToIOrderOnly()
    {
      // method belongs to IOrder only
    }
  }
}