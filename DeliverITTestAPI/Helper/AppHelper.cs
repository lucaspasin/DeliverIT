namespace DeliverITTestAPI.Helper
{
    public static class AppHelper
    {

        public static double GetCorrectedValue(double pVlOriginal, DateTime pDtDue, DateTime pDtPayment)
        {
            int daysLate = GetDayslate(pDtDue, pDtPayment);
            double vlOriginal1pc = pVlOriginal / 100;
            double fee;
            double interestDay;

            if (daysLate == 0)
            {
                return pVlOriginal;
            }

            if (daysLate <= 3)
            {
                fee = 2;
                interestDay = 0.1;

                return pVlOriginal + (fee * vlOriginal1pc) + (interestDay * daysLate);
            }

            if (daysLate <= 5)
            {
                fee = 3;
                interestDay = 0.2;

                return pVlOriginal + (fee * vlOriginal1pc) + (interestDay * daysLate);
            }

            fee = 5;
            interestDay = 0.3;

            return pVlOriginal + (fee * vlOriginal1pc) + (interestDay * daysLate);

        }

        public static int GetDayslate(DateTime pDtDue, DateTime pDtPayment)
        {
            int daysLate = (int)pDtPayment.Subtract(pDtDue).TotalDays;

            if (daysLate < 0) daysLate = 0;

            return daysLate;
        }

    }
}
