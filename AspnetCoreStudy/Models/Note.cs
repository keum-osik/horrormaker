﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetCoreStudy.Models
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]
        public int NoteNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        [Required] // Not Null 설정
        public string NoteTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        [Required] // Not Null 설정
        public string NoteContents { get; set; }

        /// <summary>
        /// 작성자 번호
        /// </summary>
        [Required] // Not Null 설정
        public int UserNo { get; set; }

        /// <summary>
        /// 왜래키 설정
        /// </summary>
        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
