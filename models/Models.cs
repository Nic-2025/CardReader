using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdCard.Hanel.Models
{

    public enum IOAction
    {
        None = 0,
        CheckIn = 1,
        CheckOut = 2,
    }

    [Table("Users")] // Ensure the table name matches the database schema
    public class User
    {
        [Key] // Mark Id as the primary key
        public int Id { get; set; }

        [Required] // Ensure Username is not null
        public string Username { get; set; } = string.Empty;

        [Required] // Ensure Password is not null
        public string Password { get; set; } = string.Empty;
    }

    public class InOutLog
    {
        public string Id { get; set; } = string.Empty;

        // Foreign key to Customer
        public string CustomerId { get; set; } = string.Empty;

        // Timestamp for Check-Out
        [Column(TypeName = "TEXT")]
        public DateTime? CheckOutTime { get; set; }

        // Renamed property
        public DateTime CheckInTime { get; set; }

        public int ManualSignOut { get; set; }

        // Navigation property
        public Customer? Customer { get; set; } = null!;

        public string InImg { get; set; } = string.Empty; // Image authen when checkin

        public string OutImg { get; set; } = string.Empty; // Image authen when checkout


        // Backing field for AdditionFields
        private string _additionFieldsJson = "{}";

        [NotMapped] // Exclude from database mapping
        public Dictionary<string, string> AdditionFields
        {
            get => JsonSerializer.Deserialize<Dictionary<string, string>>(_additionFieldsJson) ?? new Dictionary<string, string>();
            set => _additionFieldsJson = JsonSerializer.Serialize(value);
        }

        // Add a property to map the JSON string to the database
        public string AdditionFieldsJson
        {
            get => _additionFieldsJson;
            set => _additionFieldsJson = value;
        }
    }

    public class Customer
    {
        public string Id { get; set; } = string.Empty; // CCCD

        // Additional fields
        public DateTime NgayCap { get; set; } // Ngày cấp

        public DateTime NgayHetHan { get; set; } // Ngày hết hạn
        public DateTime NgaySinh { get; set; }  // Ngày sinh

        public string CMNDCu { get; set; } = string.Empty; // Số CMND cũ
        public string HoTen { get; set; } = string.Empty; // Họ tên
        public string GioiTinh { get; set; } = string.Empty;// Giới tính
        public string QuocTich { get; set; } = "";// Quốc tịch
        public string DanToc { get; set; } = "";// Dân tộc
        public string TonGiao { get; set; } = ""; // Tôn giáo
        public string QueQuan { get; set; } = ""; // Quê quán
        public string DiaChi { get; set; } = "";// Địa chỉ
        public string DacDiemND { get; set; } = "";// Đặc điểm ND
        public string Bo { get; set; } = ""; // Bố
        public string Me { get; set; } = "";// Mẹ
        public string VoChong { get; set; } = ""; // Vợ/Chồng

        public string Mrz { get; set; } = ""; // mdz

        public DateTime CreatedAt { get; set; }

        // Navigation property for InOutLogs
        public List<InOutLog>? InOutLogs { get; set; }
    }


    // public class AdditionConfig
    // {
    //     public List<AdditionField> fields { get; set; } = new List<AdditionField>();
    // }

    public enum AdditionFieldType
    {
        None = 0,

        Text = 1,
        Dropdrown = 2,

        Checkbox = 3,
    };

    public class AdditionField
    {
        public string Id { get; set; } = string.Empty;

        public bool Require { get; set; }

        public string Label { get; set; } = string.Empty;

        public string Notice { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty; // Ensure default is an empty string

        public int SortOrder { get; set; } // Property for manual sorting

        public AdditionFieldType Type { get; set; } = AdditionFieldType.Text; // Default type is text
    }

}
