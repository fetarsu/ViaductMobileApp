using ViaductMobile.Enums;

namespace ViaductMobile.Services
{
    public interface ICashMachine
    {
        CashState CashMachineState { get; }
        void ChangeCashState(TriggerCashState triggerCashState);
    }
}