namespace Euler_Project.Problems
{
    public interface IProblem
    {
        long Answer { get; set; }
        void PrintAnswer();
        void PrintProblem();
        void SolveProblem();
    }
}
