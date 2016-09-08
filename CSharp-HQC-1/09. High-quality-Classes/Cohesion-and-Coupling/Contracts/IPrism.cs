namespace CohesionAndCoupling.Contracts
{
    interface IPrism
    {
        double CalculateDiagonal3D();

        double CalculateDiagonal2D(string command);

        double CalculateVolume();
    }
}
