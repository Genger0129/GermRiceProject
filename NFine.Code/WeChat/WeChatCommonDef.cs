using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Code.WeChat
{
    public class CustomerServiceAccount
    {
        public string KfAccount { get; set; }
    }
    public class Music
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MusicUrl { get; set; }
        public string HQMusicUrl { get; set; }
        ///// <summary>
        ///// 缩略图的媒体id，通过上传多媒体文件，得到的id
        ///// 官方API上有，但是加入的话会出错
        ///// </summary>
        public string ThumbMediaId { get; set; }
    }
    public class Image
    {
        public string MediaId { get; set; }
    }
    public class Voice
    {
        public string MediaId { get; set; }
    }
    public class Video
    {
        public string MediaId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PicUrl { get; set; }
        public string Url { get; set; }
    }
    public class ResponseMessageNews : ResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.News; }
        }

        public int ArticleCount
        {
            get
            {
                return Articles == null ? 0 : Articles.Count;
            }
            set
            {
                //这里开放set只为了逆向从Response的Xml转成实体的操作一致性，没有实际意义。
            }
        }

        /// <summary>
        /// 文章列表，微信客户端只能输出前10条（可能未来数字会有变化，出于视觉效果考虑，建议控制在8条以内）
        /// </summary>
        public List<Article> Articles { get; set; }

        public ResponseMessageNews()
        {
            Articles = new List<Article>();
        }
    }
    public class ResponseMessageText : ResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Text; }
        }

        public string Content { get; set; }
    }
    public class ResponseMessageVoice : ResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Voice; }
        }

        public Voice Voice { get; set; }

        public ResponseMessageVoice()
        {
            Voice = new Voice();
        }
    }
    public class ResponseMessageVideo : ResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Video; }
        }

        public Video Video { get; set; }

        public ResponseMessageVideo()
        {
            Video = new Video();
        }
    }
    public class ResponseMessageMusic : ResponseMessageBase
    {
        public override ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Music; }
        }

        public Music Music { get; set; }
        //public string ThumbMediaId { get; set; } //把该参数移动到Music对象内部
        public ResponseMessageMusic()
        {
            Music = new Music();
        }
    }
    public class ResponseMessageImage : ResponseMessageBase
    {
        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Image; }
        }

        public Image Image { get; set; }

        public ResponseMessageImage()
        {
            Image = new Image();
        }
    }
    public class ResponseMessageTransfer_Customer_Service : ResponseMessageBase
    {
        public ResponseMessageTransfer_Customer_Service()
        {
            TransInfo = new List<CustomerServiceAccount>();
        }

        new public virtual ResponseMsgType MsgType
        {
            get { return ResponseMsgType.Transfer_Customer_Service; }
        }

        public List<CustomerServiceAccount> TransInfo { get; set; }
    }
}
