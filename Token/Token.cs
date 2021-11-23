using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Token
{
    public class Token
    {
        /// <summary>
        /// 区切り記号入りファイルを解析する場合に、フィールドが引用符で囲まれているかどうかを示します。
        /// </summary>
        public bool HasFieldsEnclosedInQuotes { get; set; } = true;


        private string Buffer;
        private int Position = 0;


        public Token()
        {
            this.SetString(null);
        }

        public Token(string value)
        {
            this.SetString(value);
        }

        public void SetString(string value)
        {
            this.Buffer = value;
            this.Position = 0;
        }

        public void ResetToken()
        {
            this.Position = 0;
        }

        public string GetToken(char delimiter)
        {
            if (this.Buffer == null) return null;

            string _result = "";

            while (this.Buffer.Length > this.Position)
            {
                if (this.Buffer[this.Position] == delimiter)
                {
                    while (this.Buffer.Length > this.Position)
                    {
                        if (this.Buffer[this.Position] != delimiter)
                        {
                            break;
                        }
                        this.Position++;
                    }
                    break;
                }
                _result += this.Buffer[this.Position];
                this.Position++;
            }

            return _result;
        }
    }
}
