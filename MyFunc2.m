function x=MyFunc2(y,NN,filePath,SNR)
[z,fs]=audioread(fullfile(filePath,y)); %fs - sample frequencies

a=awgn(z,SNR); %white gaussian noise
filename=strcat(NN,y);
fpath='E:\FisiereWAV\Workspace';
audiowrite(fullfile(fpath,filename),a,fs);
fig=figure;
set(fig,'Visible', 'off')
subplot(2,1,1);
plot(z);
title('Semnal - original');
subplot(2,1,2);
plot(a);
title('Zgomot alb Gaussian');
[filepath,name,ext]=fileparts(filename);
saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
x=a;