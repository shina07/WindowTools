namespace YoutubeDownloaderCore
{
    public enum LogType
    {
        // 디버깅용 임시 메시지
        Debug,
        // 프로그램이 임의로 처리할 수 없는 오류 발생(수행 지속 가능)
        Error,
        // 논리적으로 상정되지 않은 상황 발생(수행 지속 불가)
        Exception,
        // 로고, 경과 시간 등 일반적인 알림 메시지
        Notice,
        // 프로그램이 임의로 처리할 수도 있으나 추후 문제 발생 소지가 있음(수행 지속 가능)
        Warning,
    };

    public interface IReporter
    {
        void WriteLine(LogType t, string fmt, params object[] args);
    }
}
