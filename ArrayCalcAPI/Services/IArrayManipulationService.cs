namespace ArrayCalcAPI.Services
{
    public interface IArrayManipulationService
    {
        int[] ReverseArray(string[] productIds);
        int[] DeleteArrayElement(string[] productIds, string position);
    }
}