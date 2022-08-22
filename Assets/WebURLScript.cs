using UnityEngine;
using System;
using System.Net;
using System.IO;
using System.Collections;

public class HttpDownloadFile {

	private int bufferSize = 8192;
	private int fileSize = 0;
	private int count = 0;

	public void DownloadToFile(string url, string filePath){

		HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
		byte[] buffer = new byte[bufferSize]; 
		int size = 0;

		using(var httpResponse = (HttpWebResponse)httpRequest.GetResponse()){
			using(var dataStream = httpResponse.GetResponseStream()){
				using(var fs = new FileStream (filePath, FileMode.Create)){
					fileSize = (int) httpResponse.ContentLength;
					count = 0;
					do{
						size = dataStream.Read(buffer, 0, buffer.Length); 
						if(size > 0){
							fs.Write(buffer, 0, size);
							count += size;
						} 
					} while (size > 0);
				}
			}
		}
	}

	public byte [] DownloadToByte(string url){

		HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);

		byte[] buffer = new byte[bufferSize]; 
		int size = 0;

		using(var httpResponse = (HttpWebResponse)httpRequest.GetResponse()){
			using(var dataStream = httpResponse.GetResponseStream()){
				using(var ms = new MemoryStream ()){
					fileSize = (int) httpResponse.ContentLength;
					count = 0;
					do{
						size = dataStream.Read(buffer, 0, buffer.Length); 
						if(size > 0){
							ms.Write(buffer, 0, size);
							count += size;
						} 
					} while (size > 0);

					return ms.ToArray ();
				}
			} 
		}
	}

	public void SetBufferSize(int bufferSize){
		this.bufferSize = bufferSize;
	}

	public int GetBufferSize(){
		return bufferSize;
	}

	public float GetProgress(){
		return (float)count / (float)fileSize;
	}

	public int GetProgressFileSize(){
		return count;
	}

	public float GetProgressPercent(int point){
		double d = GetProgress () * 100;
		return (float) Math.Round(d, point);
	}

	public int GetFileSize(){
		return fileSize;
	}



}