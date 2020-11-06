namespace Services
{
    public interface IOnlinePaymentService
    {
        double PaymentFee(double amount); //taxa de pagamento
        double Interest(double amount, int months);
    }
}