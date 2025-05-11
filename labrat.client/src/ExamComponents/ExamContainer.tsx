import ExamNavbar from "@/ExamComponents/ExamNavbar.tsx";
import Question from "@/ExamComponents/Question.tsx";

//this is where question API will be pinged - response will be used to populate question component

export default function ExamContainer ()
{
    return (
        <div>
            <ExamNavbar />
            <Question />

        </div>
    )
}