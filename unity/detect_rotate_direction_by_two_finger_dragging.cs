
enum RotateDirection {
  NONE,
  LEFT,
  RIGHT
}

int _preDegree;  //前回の角度を保持

void MultiTouch () {
  Touch touch1 = Input.GetTouch(0);
  Touch touch2 = Input.GetTouch(1);
  Vector2 pos1 = touch1.position;
  Vector2 pos2 = touch2.position;

  RotateDirection rotateDirection = GetRotateDirection (pos1, pos2);

  if (rotateDirection == RotateDirection.LEFT) {
    Debug.Log ("左回り");
  } else if (rotateDirection == RotateDirection.RIGHT) {
    Debug.Log ("右回り?");
  } else {
    // 回転なし
  }
}

RotateDirection GetRotateDirection (Vector2 pos1, Vector pos2) {
  // x座標の位置でpos1とpos2を入れ替える
  if (pos1.x > pos2.x) {
    Vector2 tmp = pos1;
    pos1 = pos2;
    pos2 = tmp;
  }

  float dx = pos2.x - pos1.x;
  float dy = pos2.y - pos1.y;
  float rad = Mathf.Atan2 (dy, dx);
  int degree = Mathf.RoundToInt (rad * Mathf.Rad2Deg);
  RotateDirection rotateDirection = RotateDirection.NONE;
  if (degree - preDegree > 0) {
    rotateDirection = RotateDirection.LEFT;
  } else if (degree - preDegree < 0) {
    rotateDirection = RotateDirection.RIGHT;
  }
  preDegree = degree;
  return rotateDirection;
}
