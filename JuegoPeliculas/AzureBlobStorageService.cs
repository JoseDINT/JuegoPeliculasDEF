using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EjercicioPeliculas
{
    class AzureBlobStorageService
    {

        public AzureBlobStorageService()
        { }

        public void SubirImagenes(string rutaFicheroSubidaAzure)
        {
            //Paquete NuGet para Azure Storage Blob Service: Azure.Storage.Blobs

            string cadenaConexion = "TU_CADENA_DE_CONEXION";
            //La obtenemos en el portal de Azure, asociada a la cuenta de almacenamiento
            string nombreContenedorBlobs = "Imagenes";
            //El nombre que le hayamos dado a nuestro contenedor de blobs en el portal de Azure
            string rutaImagen = rutaFicheroSubidaAzure;

            //Obtenemos el cliente del contenedor
            var clienteBlobService = new BlobServiceClient(cadenaConexion);
            var clienteContenedor = clienteBlobService.GetBlobContainerClient(nombreContenedorBlobs);

            //Leemos la imagen y la subimos al contenedor
            Stream streamImagen = File.OpenRead(rutaImagen);
            string nombreImagen = Path.GetFileName(rutaImagen);
            clienteContenedor.UploadBlob(nombreImagen, streamImagen);

            //Una vez subida, obtenemos la URL para referenciarla
            var clienteBlobImagen = clienteContenedor.GetBlobClient(nombreImagen);
            string urlImagen = clienteBlobImagen.Uri.AbsoluteUri;
        }
    }


}
