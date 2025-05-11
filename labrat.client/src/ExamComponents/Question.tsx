export default function Question ({answers, questionText}) {
    return (
        <div className="flex flex-col items-center justify-center h-screen bg-gray-100">
            <h1 className="text-2xl font-bold mb-4">Question</h1>
            <form className="bg-white shadow-md rounded px-8 pt-6 pb-8 mb-4 w-full max-w-sm">
                <div className="mb-4">
                    <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="question">
                        Question
                    </label>
                    <input
                        type="text"
                        id="question"
                        placeholder="Your Question"
                        className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                    />
                </div>
                <div className="mb-4">
            <ul>
                <li>Choice</li>
            </ul>

                </div>
            </form>
        </div>
    );
}