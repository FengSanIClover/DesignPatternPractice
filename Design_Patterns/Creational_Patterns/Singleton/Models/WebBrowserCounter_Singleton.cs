using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Models
{
    /// <summary>
    /// 網站瀏覽計數器類別-單例模式
    /// </summary>
    public class WebBrowserCounter_Singleton
    {
        // 執行緒鎖定用 obj
        private static object lockObj = new object();

        private static WebBrowserCounter_Singleton instance = null;

        // 執行緒安全的建立方式1
        private static WebBrowserCounter_Singleton instanceMethod = new WebBrowserCounter_Singleton();
        private WebBrowserCounter_Singleton GetInstanceMethod1 
        {
            get
            {
                return instanceMethod;
            }
        }

        // 使用 Lazy<T>，可以簡單的達成 Singleton 要求的 唯一 與 延遲建立
        private static Lazy<WebBrowserCounter_Singleton> instanceMethod2 = new Lazy<WebBrowserCounter_Singleton>(() => new WebBrowserCounter_Singleton());
        private WebBrowserCounter_Singleton GetInstanceMethod2
        {
            get
            {
                return instanceMethod2.Value;
            }
        }


        // 私有建構子，無法直接建立實體
        private WebBrowserCounter_Singleton() { }

        /// <summary>
        /// 計數次數
        /// </summary>
        public int Count { get; set; } = 0;

        /// <summary>
        /// 取得執行個體
        /// </summary>
        /// <returns></returns>
        public static WebBrowserCounter_Singleton GetInstance()
        {
            // 使用 Double-checked Locking 確保執行緒安全
            if (instance == null)
            {
                // 運用 lock 鎖定執行緒執行，避免創立多個類別
                // 假設執行緒 A 先執行，執行緒 B 稍微慢一點。
                // 執行緒 A 執行到 lock 語句，判斷 obj 是否已申請了互斥鎖，
                // 判斷依據是逐個與已存在的鎖進行 object.ReferenceEquals 比較(此處未加證實)，
                // 如果不存在，則申請一個新的互斥鎖，這時執行緒 A 進入lock裡面了。
                // 這時假設執行緒 B 啟動了，而執行緒 A 還未執行完 lock 裡面的代碼。
                // 執行緒 B 執行到lock語句，檢查到 obj 已經申請了互斥鎖，於是等待;
                // 直到執行緒 A 執行完畢，釋放互斥鎖，執行緒 B 才能申請新的互斥鎖並執行lock 裡面的代碼
                lock (lockObj)
                {
                  if(instance == null)
                    {
                        instance = new WebBrowserCounter_Singleton();
                    }
                }
            }

            return instance;
        }
    }
}
