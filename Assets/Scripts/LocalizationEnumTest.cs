using UnityEngine;

public class LocalizationEnumTest : MonoBehaviour
{
    void Start()
    {
        var Text1Key0 = LangTextKey.LangTextKeyUtil.GetLocalizedText(LangTextKey.Text1.Key0);
        var Text1Key1 = LangTextKey.LangTextKeyUtil.GetLocalizedText(LangTextKey.Text1.Key1);
        var Text2Key0 = LangTextKey.LangTextKeyUtil.GetLocalizedText(LangTextKey.Text2.Key0);
        var Text2Key1 = LangTextKey.LangTextKeyUtil.GetLocalizedText(LangTextKey.Text2.Key1);
        Debug.Log(Text1Key0);
        Debug.Log(Text1Key1);
        Debug.Log(Text2Key0);
        Debug.Log(Text2Key1);
    }
}
