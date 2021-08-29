using Livet;
using System.Collections.Generic;

namespace ShogiEnteringKingScoreingWpf.ViewModels
{
    class UserControl1ViewModel : ViewModel
    {
        private string _url = string.Empty;

        /// <summary>
        /// URLのテキスト
        /// </summary>
        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                if (this._url == value)
                {
                    return;
                }
                this._url = value;
                RaisePropertyChanged("Url");
            }
        }

        private Dictionary<string, string> _tournament = new Dictionary<string, string>(){
            { "floodgate", "フラッドゲート" },
            { "denryu-sen", "電竜戦" }
        };

        /// <summary>
        /// 棋譜を読みに行く間隔（秒）
        /// </summary>
        public Dictionary<string, string> Tournament
        {
            get
            {
                return this._tournament;
            }
            set
            {
                if (this._tournament == value)
                {
                    return;
                }
                this._tournament = value;
                RaisePropertyChanged("Tournament");
            }
        }

        private int _intervalSeconds = 15;

        /// <summary>
        /// 棋譜を読みに行く間隔（秒）
        /// </summary>
        public int IntervalSeconds
        {
            get
            {
                return this._intervalSeconds;
            }
            set
            {
                if (this._intervalSeconds == value)
                {
                    return;
                }
                this._intervalSeconds = value;
                RaisePropertyChanged("IntervalSeconds");
            }
        }

        private string _status = string.Empty;

        /// <summary>
        /// 状況のテキスト
        /// </summary>
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                if (this._status == value)
                {
                    return;
                }
                this._status = value;
                RaisePropertyChanged("Status");
            }
        }

        private string _position = string.Empty;

        /// <summary>
        /// 局面のテキスト
        /// </summary>
        public string Position
        {
            get
            {
                return this._position;
            }
            set
            {
                if (this._position == value)
                {
                    return;
                }
                this._position = value;
                RaisePropertyChanged("Position");
            }
        }
    }
}
