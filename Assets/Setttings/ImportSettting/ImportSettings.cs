using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ImportSettings : AssetPostprocessor
{
    void OnPostprocessTexture(Texture2D texture)
    {
        TextureImporter textureImporter = (TextureImporter)assetImporter;
        textureImporter.maxTextureSize = 1024;
        textureImporter.textureType = TextureImporterType.Sprite;
        if (textureImporter.textureCompression != TextureImporterCompression.Compressed && textureImporter.textureCompression != TextureImporterCompression.CompressedLQ)
        {
            textureImporter.textureCompression = TextureImporterCompression.Compressed;
        }
        textureImporter.spriteImportMode = SpriteImportMode.Single; //��ͼ
        textureImporter.spritePixelsPerUnit = 100; //ÿ��λ������

        // gut Text 2

        textureImporter.sRGBTexture = true;
    }

    void OnPostprocessAudio(AudioClip audioClip)
    {
        AudioImporter audioImporter = (AudioImporter)assetImporter;
        AudioImporterSampleSettings settings = new AudioImporterSampleSettings();
        settings.sampleRateSetting = AudioSampleRateSetting.PreserveSampleRate;
        if (audioClip.length < 3)
        {
            settings.loadType = AudioClipLoadType.DecompressOnLoad;
        }
        audioImporter.defaultSampleSettings = settings;
    }
}
