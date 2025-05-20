using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.App.Utils.PicturePath;

public static class SelectImage
{
    public static string Now()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Selecione uma imagem";
        openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
        string initialPath = Path.Combine(Application.StartupPath, "Pictures\\Employee");
        openFileDialog.InitialDirectory = initialPath;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string imagemPath = openFileDialog.FileName;
            string imagemName = Path.GetFileName(imagemPath);
            string destinationPath = Path.Combine(initialPath, imagemName);
            if (imagemPath != destinationPath)
            {
                File.Copy(imagemPath, destinationPath, overwrite: true);
            }
            return destinationPath;
        }
        return string.Empty;
    }
}
