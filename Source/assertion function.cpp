nsTextFrame::TrimmedOffsets
nsTextFrame::GetTrimmedOffsets(const nsTextFragment* aFrag,
                               bool aTrimAfter, bool aPostReflow)
{
  NS_ASSERTION(mTextRun, "Need textrun here");
  if (aPostReflow) {
    // This should not be used during reflow. We need our TEXT_REFLOW_FLAGS
    // to be set correctly.  If our parent wasn't reflowed due to the frame
    // tree being too deep then the return value doesn't matter.
    NS_ASSERTION(!(GetStateBits() & NS_FRAME_FIRST_REFLOW) ||
                 (GetParent()->GetStateBits() &
                  NS_FRAME_TOO_DEEP_IN_FRAME_TREE),
                 "Can only call this on frames that have been reflowed");
    NS_ASSERTION(!(GetStateBits() & NS_FRAME_IN_REFLOW),
                 "Can only call this on frames that are not being reflowed");
  }

  TrimmedOffsets offsets = { GetContentOffset(), GetContentLength() };
  const nsStyleText* textStyle = StyleText();
  // Note that pre-line newlines should still allow us to trim spaces
  // for display
  if (textStyle->WhiteSpaceIsSignificant())
    return offsets;

  if (!aPostReflow || (GetStateBits() & TEXT_START_OF_LINE)) {
    int32_t whitespaceCount =
      GetTrimmableWhitespaceCount(aFrag,
                                  offsets.mStart, offsets.mLength, 1);
    offsets.mStart += whitespaceCount;
    offsets.mLength -= whitespaceCount;
  }

  if (aTrimAfter && (!aPostReflow || (GetStateBits() & TEXT_END_OF_LINE))) {
    // This treats a trailing 'pre-line' newline as trimmable. That's fine,
    // it's actually what we want since we want whitespace before it to
    // be trimmed.
    int32_t whitespaceCount =
      GetTrimmableWhitespaceCount(aFrag,
                                  offsets.GetEnd() - 1, offsets.mLength, -1);
    offsets.mLength -= whitespaceCount;
  }
  return offsets;
}