function x=MyFunc3(y,E,filePath)
[z,fs]=audioread(fullfile(filePath,y)); %fs - sample frequencies

if strcmp(E,'Echo-')
    echo_z=z; 
    N=fs/2;
    for n=N+1:length(z)
        echo_z(n,1)=z(n,1)+z(n-N,2);
        echo_z(n,2)=z(n,2)+z(n-N,1);
    end
    filename=strcat(E,y);
    fpath='E:\FisiereWAV\Workspace';
    audiowrite(fullfile(fpath,filename),echo_z,fs);
    fig=figure;
    set(fig,'Visible', 'off')
    subplot(2,1,1);
    plot(z);
    title('Semnal - original');
    subplot(2,1,2);
    plot(echo_z);
    title('Ecou semnal - original');
    [filepath,name,ext]=fileparts(filename);
    saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
    x=echo_z;
elseif strcmp(E,'REcho-')
    z_left=z(:,1);
    z_right=z(:,2);
    z_rez=z_left-z_right;
    filename=strcat(E,y);
    fpath='E:\FisiereWAV\Workspace';
    audiowrite(fullfile(fpath,filename),z_rez,fs);
    fig=figure;
    set(fig,'Visible', 'off')
    subplot(2,1,1);
    plot(z);
    title('Semnal - original');
    subplot(2,1,2);
    plot(z_rez);
    title('Reducere ecou');
    [filepath,name,ext]=fileparts(filename);
    saveas(fig,fullfile(fpath, strcat(name,'.jpg')));
    x=z_rez;
end