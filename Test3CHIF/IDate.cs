namespace TestUeben {
    public interface IDate {
        int Day { get; set; }
        int DayOfYear { get; }
        int Month { get; set; }
        int Year { get; set; }
    }
}