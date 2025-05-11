export default function BottomNavbar() {
    return (
        <div className="fixed bottom-0 left-0 right-0 z-50 flex items-center justify-between bg-white border-t border-gray-200 p-4">
        <div className="flex items-center space-x-4">
            <a href="/home" className="text-gray-600 hover:text-blue-500">
            Home
            </a>
            <a href="/profile" className="text-gray-600 hover:text-blue-500">
            Profile
            </a>
            <a href="/settings" className="text-gray-600 hover:text-blue-500">
            Settings
            </a>
        </div>
        </div>
    );
}