using UnityEngine;

public class Block : MonoBehaviour
{
    // ID để phân biệt các loại block (sau này dùng để tính điểm hoặc logic game)
    // HideInInspector nghĩa là không hiện trong Inspector cho đỡ rối, vì ta gán bằng code
    [HideInInspector] public string blockID;

    void Start()
    {
        // Tự động lấy tên của GameObject làm ID (VD: Block_L, Block_Square...)
        blockID = gameObject.name;
    }

    // Hàm này sau này sẽ dùng để xử lý việc Kéo Thả (Drag & Drop)
    // Tạm thời để trống, ta sẽ quay lại viết sau
}