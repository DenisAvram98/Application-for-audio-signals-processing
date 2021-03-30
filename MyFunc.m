function x=MyFunc(y,fN,filePath,n,f,f1)
[z,fs]=audioread(fullfile(filePath,y)); %fs - sample frequencies

%f=0.8; %cutoff frequency (Wn)
%n=6; %filter order (N)

if strcmp(fN,'LPF-')
    b=fir1(n,f,'low');
    o=filter(b,1,z);
    filename=strcat(fN,y);
    fpath='E:\FisiereWAV\Workspace';
    audiowrite(fullfile(fpath,filename),o,fs);
    fig=figure;
    set(fig,'Visible', 'off')
    subplot(2,1,1);
    plot(z);
    title('Semnal - original');
    subplot(2,1,2);
    plot(o);
    title('Filtru trece-jos');
    [filepath,name,ext]=fileparts(filename);
    saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
    x=o;
elseif strcmp(fN,'HPF-')
    a=fir1(n,f,'high');
    o=filter(a,1,z);
    filename=strcat(fN,y);
    fpath='E:\FisiereWAV\Workspace';
    audiowrite(fullfile(fpath,filename),o,fs);
    fig=figure;
    set(fig,'Visible', 'off')
    subplot(2,1,1);
    plot(z);
    title('Semnal - original');
    subplot(2,1,2);
    plot(o);
    title('Filtru trece-sus');
    [filepath,name,ext]=fileparts(filename);
    saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
    x=o;
elseif strcmp(fN,'BPF-')
    f2=[f f1];
    c=fir1(n,f2,'bandpass');
    o=filter(c,1,z);
    filename=strcat(fN,y);
    fpath='E:\FisiereWAV\Workspace';
    audiowrite(fullfile(fpath,filename),o,fs);
    fig=figure;
    set(fig,'Visible','off');
    subplot(2,1,1);
    plot(z);
    title('Semnal - original');
    subplot(2,1,2);
    plot(o);
    title('Filtru trece-banda');
    [filepath,name,ext]=fileparts(filename);
    saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
    x=o;
elseif strcmp(fN, 'BSF-')
    f2=[f f1];
    c=fir1(n,f2,'stop');
    o=filter(c,1,z);
    filename=strcat(fN,y);
    fpath='E:\FisiereWAV\Workspace';
    audiowrite(fullfile(fpath,filename),o,fs);
    fig=figure;
    set(fig,'Visible','off');
    subplot(2,1,1);
    plot(z);
    title('Semnal - original');
    subplot(2,1,2);
    plot(o);
    title('Filtru opreste banda');
    [filepath,name,ext]=fileparts(filename);
    saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
    x=o; 
end