/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package App;

import Modelo.Imagem;
import Modelo.Pasta;
import Modelo.Texto;
import Modelo.Video;

/**
 *
 * @author Leonardo
 */
public class Main {
    public static void main(String[] args) {
        Imagem imagem = new Imagem("img.jpeg");
        Texto texto = new Texto("texto.txt");
        Video video = new Video("video.mp4");
        
        Pasta documentos = new Pasta("Documentos");
        documentos.addArquivos(imagem);
        documentos.addArquivos(texto);
        documentos.addArquivos(video);
        
        Pasta fotos = new Pasta("Fotos");
        fotos.addArquivos(imagem);
        fotos.addArquivos(imagem);
        fotos.addArquivos(imagem);
        fotos.addArquivos(imagem);
        fotos.addArquivos(imagem);
        fotos.addArquivos(imagem);
        
        Pasta videos = new Pasta("Videos");
        videos.addArquivos(video);
        videos.addArquivos(video);
        videos.addArquivos(video);
       
        documentos.imprime();
        fotos.imprime();
        videos.imprime();
    }
}
