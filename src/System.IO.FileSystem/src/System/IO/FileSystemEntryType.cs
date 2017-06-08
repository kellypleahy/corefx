namespace System.IO
{
    internal enum FileSystemEntryType
    {
        /// <summary>
        /// The file system entry was not found
        /// </summary>
        NotFound,

        /// <summary>
        /// One or more of the path parts (directories) are not available to the executing user
        /// </summary>
        AccessDenied,

        /// <summary>
        /// An error occurred for which this function is not coded
        /// </summary>
        UnknownError,

        /// <summary>
        /// The entry is a regular file
        /// </summary>
        File,

        /// <summary>
        /// The entry is a directory
        /// </summary>
        Directory,

        /// <summary>
        /// The entry is a symlink that does not have a valid target
        /// </summary>
        InvalidSymLink,

        /// <summary>
        /// The terminal entry (final entry in path) is a symlink
        /// </summary>
        SymLink,

        /// <summary>
        /// The entry is a block device (buffered)
        /// </summary>
        BlockDevice,

        /// <summary>
        /// The entry is a character device (unbuffered)
        /// </summary>
        CharDevice,

        /// <summary>
        /// The entry is a pipe (FIFO)
        /// </summary>
        Pipe,

        /// <summary>
        /// The entry is a socket
        /// </summary>
        Socket,

        /// <summary>
        /// The path provided has too many symlinks in it (possibly a loop)
        /// </summary>
        TooManyLinks,

        /// <summary>
        /// The path provided is too long
        /// </summary>
        PathTooLong,

        /// <summary>
        /// One or more of the path parts (directories) is not a directory
        /// </summary>
        InvalidSubpath,

        /// <summary>
        /// The device on which the path is located is not ready
        /// </summary>
        DeviceNotReady,

        /// <summary>
        /// The drive supplied in the path does not exist
        /// </summary>
        InvalidDrive,

        /// <summary>
        /// The path represents some sort of file system entry that is not recognized by this function
        /// </summary>
        Unrecognized,
    }
}